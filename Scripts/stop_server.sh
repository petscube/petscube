#!/bin/bash
export DOTNET_CLI_HOME=/temp
sudo kill $(sudo lsof -t -i:8080)