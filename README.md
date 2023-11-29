1.	Introducción:

Bienvenido al Manual Técnico del Software de Gestión Integral de Ventas de Productos VDP. Este documento ha sido elaborado con el propósito de proporcionar una guía detallada y exhaustiva para usuarios, administradores y profesionales de tecnología de la información involucrados en la implementación y operación eficiente de nuestro software.

El Software de Gestión Integral de Ventas de VDP se erige como una solución integral para la administración eficaz de clientes, empleados, productos y procesos de venta. Este manual presenta una descripción técnica completa de las funcionalidades del software, así como instrucciones detalladas sobre su instalación, configuración y uso. Concebido para ser una referencia inestimable, aborda específicamente la interacción con la base de datos de clientes, la gestión de empleados, el catálogo de productos y las operaciones de ventas, brindando un marco sólido para la optimización de las operaciones comerciales. 

2.	Descripción del proyecto:
El proyecto en cuestión es una iniciativa integral de desarrollo de software orientada a la creación de un sistema de gestión de ventas avanzado. Diseñado para optimizar la administración de clientes, empleados, productos y procesos de venta, el proyecto busca ofrecer una solución tecnológica completa que impulse la eficiencia operativa y mejore la toma de decisiones empresariales. Con un enfoque centrado en la usabilidad y la funcionalidad, el proyecto aborda la complejidad de las operaciones comerciales al proporcionar una plataforma intuitiva y robusta. Desde la conceptualización hasta la implementación, se busca establecer un estándar de excelencia en la gestión empresarial, permitiendo a las organizaciones optimizar sus recursos y potenciar su capacidad para adaptarse dinámicamente a las demandas del mercado.

  Roles / integrantes
1.	Team Líder, GIT Master: Cesar Alberto Peñaloza 
2.	DB Arquitect, Developer: Rafael Arévalo Bascope 
3.	 Developer: Mariana Estefanía Andrew Cardoso

3.	Arquitectura del software: 
La arquitectura de un software para la gestión de ventas, utilizando Windows Communication Foundation (WCF) y conectada a una base de datos en SQL Server, se configura para proporcionar una solución escalable y eficiente. 

En esta arquitectura, la capa de presentación o interfaz de usuario interactúa con el backend a través de servicios WCF. Estos servicios actúan como un puente entre la interfaz de usuario y la lógica de negocio, permitiendo una separación clara de responsabilidades y facilitando la interoperabilidad entre diferentes componentes del sistema. 

La lógica de negocio se implementa en servicios WCF, que pueden abarcar funciones como la gestión de clientes, productos, empleados y operaciones de venta. Estos servicios se encargan de procesar las solicitudes de la interfaz de usuario, aplicar las reglas de negocio y realizar operaciones en la base de datos. 

La capa de acceso a datos se conecta a la base de datos SQL Server para recuperar y almacenar información relevante. Aquí, se gestionan consultas, inserciones, actualizaciones y eliminaciones de datos, asegurando la integridad de la información y la eficiencia en las operaciones de la base de datos.

La seguridad y la gestión de sesiones pueden implementarse a través de las capacidades de seguridad de WCF y la autenticación en la base de datos SQL Server. Además, la arquitectura puede contemplar la implementación de patrones de diseño como Inyección de Dependencias para promover la mantenibilidad y la flexibilidad del código.

En resumen, la arquitectura propuesta utiliza WCF para facilitar la comunicación entre la interfaz de usuario y la lógica de negocio, mientras que la capa de acceso a datos se encarga de interactuar con la base de datos SQL Server. Esta estructura proporciona una base sólida para un sistema de gestión de ventas eficiente, escalable y bien estructurado.
4.	Requisitos del sistema:
•	Requerimientos de Hardware (mínimo): (cliente)
El hardware mínimo es que contar con una computadora con un procesador Intel core i5 mínimo, 4GB de RAM
•	Requerimientos de Software: (cliente)
Tener SQL SERVER versión 2018 en adelante.
•	Requerimientos de Hardware (server/ hosting/BD)
      	      Procesador (CPU):
Tipo: Intel Core i5 o AMD Ryzen 5 son opciones comunes para usuarios promedio.
Velocidad: 2.5 GHz o superior.
Memoria RAM:
Capacidad: 8 GB a 16 GB de RAM es típico para tareas cotidianas. Más RAM puede ser beneficioso para tareas más intensivas.
Almacenamiento:
Tipo: Disco duro (HDD) de 1 TB o unidad de estado sólido (SSD) de 256 GB. Algunas PCs pueden tener una combinación de ambos para aprovechar la velocidad del SSD y la capacidad del HDD.

5.	Instalación y configuración: Instrucciones detalladas sobre cómo instalar el software, configurar los componentes necesarios y establecer la conexión con otros sistemas o bases de datos
-	Descargar proyecto
-	Descomprimir el proyecto del punto Rar
-	Restaurar la base de datos (.bak) en Sql Server
-	Introducir el nombre del servidor SQL SERVER en el archivo web.config
- Recompilar la solución y establecer la tercera capa, WAVDP, como proyecto de inicio.
  
Depuración y solución de problemas: 
En caso de que el programa presente errores cierra la aplicación, establece capa por capa (por orden) como proyecto de inicio y recompila de nuevo la solucion, caso contrario pueda contactarse con el ingeniero de soporte técnico.

Herramientas de Implementación:
•	Lenguajes de programación:
Los lenguaje de programación  que se usaron fueron C#, JavaScript.
•	Frameworks:
El frameowrk fue ASP.NET WFC

Video https://youtu.be/G8fcAwb06T4?si=zZUTGvI4gjOZysNK
