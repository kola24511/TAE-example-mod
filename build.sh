#!/usr/bin/env sh
set -eu

case "$0" in
    */*) script_dir=${0%/*} ;;
    *) script_dir=. ;;
esac
CDPATH= cd -- "$script_dir"

if ! command -v dotnet >/dev/null 2>&1; then
    printf '%s\n' '.NET SDK is required. Install it and reopen your terminal.' >&2
    exit 1
fi

exec dotnet build ExampleMod.csproj -c Release --nologo
