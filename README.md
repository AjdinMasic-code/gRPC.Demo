This project is a demo project of gRPC. If you want a quick look see:

Run without debugging in this order:
gRPC.Demo.Service
gRPC.Client.Service

gRPC.Client.Service is just a super basic implementation of gRPC via a console app.
gRPC.Demo.Service is the gRPC server.

If you want to test gRPC integration with MVC order doesn't matter since the channel is not created on launch rather, the connection happens when you submit a form.

The apps to run in non-debug mode are:
gRPC.Demo.Service
gRPC.Demo.Web
