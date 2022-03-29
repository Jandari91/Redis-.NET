FROM python:latest

WORKDIR /app/

COPY ./PyWorker.py .

ENV SLEEP=10

CMD python ./PyWorker.py ${SLEEP}
