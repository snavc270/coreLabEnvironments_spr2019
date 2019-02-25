
# Basic Cat Chat

Barebones chat example for socket.io

## What is node? 
An open source server environment that uses JavaScript on the server. 
It is asynchronous! In a PHP web server, to process a resquest: 
1. Send the task to the computer's file system 
2. Waits while the system reads the file 
3. Server returns info to the client 
4. And only then is ready to handle the next request. 

BUT WITH NODE....
1. Send the task to the computer's file system 
2. Able to handle the next request without waiting
3. When the system reads the file, server returns info to the client


## What is NPM? 
A software library. Contains a ton of code packages that you can install and use in your web projects. NPM = node package manager, because it was originally build as a software management tool for node.js. 

## How to use

```
$ cd EasyPeasyChat
$ npm install // YOU ONLY NEED TO INSTALL NPM THE FIRST TIME YOU RUN YOUR SERVER!
$ node app.js

```

And point your browser to `http://localhost:8080`
## Features

- Submit your username
- You will enter the chatroom
- You will be notified of other existing users. 
