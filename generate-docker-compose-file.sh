#!/bin/sh

#define parameters which are passed in.
IMAGE_TAG=$1

#define the template.
cat  << EOF
version: '3.4'

services:
  
  web:
    restart: always
    image: registry.gitlab.com/kuper-adrian/turnip-exchange/web:$IMAGE_TAG
    build:
      context: .
      dockerfile: TurnipExchange/Dockerfile
    container_name: turnip-exchange-web
    environment:
      ASPNETCORE_URLS: http://+:6000
  
  nginx:
    restart: always
    image: registry.gitlab.com/kuper-adrian/turnip-exchange/nginx:$IMAGE_TAG
    build:
      context: .
      dockerfile: nginx/Dockerfile
    container_name: turnip-exchange-nginx
EOF
