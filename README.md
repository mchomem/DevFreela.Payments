# DevFreela.Payments

DevFreela.Payments.API is a microservice designed to process payments from data originating from the [DevFreela](https://github.com/mchomem/DevFreela) project,
using the RabbitMQ queuing procedure.
Currently, processing is only abstract, not connecting to any payment platform, but there are future plans to implement a platform with PayPal,
as a full demonstration of the project flow.

## Dependences

1. RabbitMQ

To run this project, you must have an instance of the RabbitMQ service running. The easiest way to create the service is through a docker container.
Windows users can have a [Docker Desktop](https://www.docker.com/products/docker-desktop/) installation (running) and run the following command to 
make the RabbitMQ service available:

`docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3.13-management`

To monitor and even manage DevFreela messages in RabbitMQ, you can use the RabbitMQ manager itself, which is hosted where the docker container is running, 
available at http://localhost:15672/.
Username and password in the basic configuration is `guest`.