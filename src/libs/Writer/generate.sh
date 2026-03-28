#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
SPEC_URL=$(curl --fail --silent --show-error https://raw.githubusercontent.com/writer/writer-python/main/.stats.yml | grep 'openapi_spec_url' | awk '{print $2}' | tr -d '"')
curl --fail --silent --show-error -L "$SPEC_URL" -o openapi.yaml
autosdk generate openapi.yaml \
  --namespace Writer \
  --clientClassName WriterClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
