#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# Official API schema linked from https://dev.writer.com/llms.txt.
# Preserve the current /v1 API; the separate legacy schema describes an older API.
spec_tmp="$(mktemp)"
trap 'rm -f "$spec_tmp"' EXIT
fetch_spec --fail --silent --show-error -L https://dev.writer.com/api-reference/gateway-api-schema.yaml -o "$spec_tmp"
# Retain the established Function(arguments, name) positional constructor while
# preserving the provider's new required-name constraint and all schema fields.
yq -o=json . "$spec_tmp" | jq '
  if (.components.schemas.function.properties | has("arguments") and has("name")) then
    .components.schemas.function.properties |= ({arguments: .arguments} + .)
    | .components.schemas.function.required |= (["arguments", "name"] + map(select(. != "arguments" and . != "name")))
  else error("Writer function schema changed; review constructor compatibility") end
' > openapi.yaml
if [[ -n "${AUTOSDK_EXECUTABLE:-}" ]]; then
  autosdk() { "$AUTOSDK_EXECUTABLE" "$@"; }
else
  install_autosdk_cli
fi
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Writer \
  --clientClassName WriterClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
