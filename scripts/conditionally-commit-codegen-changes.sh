#!/bin/bash

if [[ $(git status --porcelain | wc -l) -gt 0 ]]; then
  git add --all
  git commit -m "data: regenerating based on the latest Swagger"
else
  exit 1
fi