FROM nginx:1.15.12-alpine

COPY ./nginx/default.conf /etc/nginx/conf.d/

RUN mkdir /etc/letsencrypt

VOLUME /etc/letsencrypt
