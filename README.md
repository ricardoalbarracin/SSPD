## Servicio SSPD

### descripción
Este es un servicio web tipo api rest, desarrollado utilizando .net 6.0, esta documentado usando Swagger y se realizara el despliegue a diferentes entornos usando contenedores docker.

### Instalación
Para realizar la instalacion se realizara usando docker mediante el archivo dockerfile, para esto se debe seguir los siguientes pasos:


#### Descargar codigo fuente
Se debe realizar la descarga del codigo fuente mediante el siguiente comando *git clone XXXXX*

#### Construir imagen docker
Se debe realizar la Construición de la  imagen docker siguiente los siguientes pasos
1. ubicarse en el directorio del codigo fuente: *cd WebApi*
2. construir imagen : *docker build -f .\ApiSSPD\Dockerfile -t aspnetapp .*

#### Correr imagen docker
Se debe realizar la ejecución de la imagen: *docker run -it --rm -p 5000:80 --name aspnetcore_sspd aspnetapp*
En este caso se ejecutara usando el puerto 5000.

#### Realizar pruebas usando swagger
se debe realizar el consumo del api usando swagger http://localhost:5000/swagger/index.html


