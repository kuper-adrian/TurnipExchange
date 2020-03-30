#!/bin/sh

#define parameters which are passed in.
#GMAIL_ADDRESS=$1
#GMAIL_APP_PASSWORD=$2

#define the template.
cat  << EOF
version: '3.4'

services:

  web:
    volumes:
      - /turnip-exchange/Data/:/app/Data/

  nginx:
    volumes:
      - /etc/letsencrypt/:/etc/letsencrypt/
    ports:
      - 80:80
      - 443:443
EOF
