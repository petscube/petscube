#!/bin/bash
export DOTNET_CLI_HOME=/temp
cd /home/ubuntu/petscube/petscube/ApoptionBackend
sudo dotnet run --urls http://0.0.0.0:5000 > /dev/null 2> /dev/null < /dev/null & 