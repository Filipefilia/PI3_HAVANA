#!/bin/bash

#uso: passar como argumento x para somente executar o exe.

file=*.csproj
exe=./bin/Debug/*.exe

if [[ "$1" == "x" ]] && ! [[ -f "$exe" ]]; then
  mono $exe
else
  if ! [[ -f "$file" ]]; then
    echo -e "\nCompiling..\n"
    msbuild $file && echo -e "\nCompilation successful!\n" && mono $exe
  else
    echo -e "\nFile .csproj not found!\n"
  fi
fi
