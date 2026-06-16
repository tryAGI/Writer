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

# OpenAPI spec: resolved from writer/writer-python/.stats.yml (Stainless-hosted)
install_autosdk_cli
rm -rf Generated
SPEC_URL=$(fetch_spec --fail --silent --show-error -L https://raw.githubusercontent.com/writer/writer-python/main/.stats.yml | grep 'openapi_spec_url' | awk '{print $2}' | tr -d '"')
fetch_spec --fail --silent --show-error -L "$SPEC_URL" -o openapi.yaml
autosdk generate openapi.yaml \
  --namespace Writer \
  --clientClassName WriterClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
