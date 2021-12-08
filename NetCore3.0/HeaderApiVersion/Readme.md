#  Header based versioning #

## 1. Calling version-1 ##
-------------------------------------
### REQUEST ###
> **GET**: [http://localhost:3815/api/values](http://localhost:3815/api/values) 
> ***Header***: *Key*=`x-api-version`, *Value*=`1.0`
> Default Version=1.0
### RESPONSE ###
#### Response Header ####
> api-supported-versions →1.0, 2.0
#### Response Body ####
> Controller = ValuesController
> Version = 1.0

## 2. Calling version-2 ##
-------------------------------------
> **GET**: [http://localhost:3815/api/values](http://localhost:3815/api/values) 
> ***Header***: *Key*=`x-api-version`, *Value*=`2.0`
> Default Version=1.0
### RESPONSE ###
#### Response Header ####
> api-supported-versions →1.0, 2.0
#### Response Body ####
> Controller = ValuesController
> Version = 2.0


## Note ##
If `options.DefaultApiVersion = new ApiVersion(1, 0);` is not set then server responds with error 
*{"error":{"code":"ApiVersionUnspecified","message":"An API version is required, but was not specified.","innerError":null}}*
else `1.0` is considred as default version

