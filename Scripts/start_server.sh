#!/bin/bash
export DOTNET_CLI_HOME=/temp
cd /home/ubuntu/upgoals/UpGoals/Backend
sudo dotnet run > /dev/null 2> /dev/null < /dev/null & 