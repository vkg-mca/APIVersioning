#  Basic (Query String based ) versioning #

## 1. Calling version-1 ##
-------------------------------------
### REQUEST ###
> **GET**: [http://localhost:3814/api/values?api-version=1.0](http://localhost:3814/api/values?api-version=1.0) 
> ***Header***: *Key*=`x-api-version`, *Value*=`1.0`
### RESPONSE ###
#### Response Header ####
> api-supported-versions →1.0, 2.0
#### Response Body ####
> Controller = ValuesController
> Version = 1.0



## 2. Calling version-2 ##
-------------------------------------
### REQUEST ###
> **GET**: [http://localhost:3814/api/values?api-version=2.0](http://localhost:3814/api/values?api-version=2.0) 
> ***Header***: *Key*=`x-api-version`, *Value*=`2.0`
### RESPONSE ###
#### Response Header ####
> api-supported-versions →1.0, 2.0
#### Response Body ####
> Controller = ValuesController
> Version = 2.0
