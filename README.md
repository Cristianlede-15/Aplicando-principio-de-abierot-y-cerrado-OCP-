# Aplicando el Principio de Abierto/Cerrado (OCP)

Este proyecto es una demostración práctica de la implementación del Principio de Abierto/Cerrado (Open/Closed Principle, OCP) de SOLID en C#. El OCP establece que las entidades de software (clases, módulos, funciones, etc.) deben estar abiertas para la extensión, pero cerradas para la modificación.

## Estructura del Proyecto

El proyecto está organizado en las siguientes clases:

- **Course.cs**: Clase base que representa un curso genérico.
- **HybridCourse.cs**: Clase que representa un curso híbrido, derivada de `Course`.
- **OfflineCourse.cs**: Clase que representa un curso offline, derivada de `Course`.
- **OnlineCourse.cs**: Clase que representa un curso online, derivada de `Course`.
- **Program.cs**: Clase principal que contiene el punto de entrada del programa.
- **Student.cs**: Clase que representa a un estudiante.

## Requisitos

- .NET 6.0 o superior
- Visual Studio 2022 o cualquier IDE compatible con .NET 6.0

## Uso

1. Clona el repositorio en tu máquina local:
    ```bash
    git clone https://github.com/tu_usuario/Aplicando-principio-de-abierto-y-cerrado-OCP.git
    ```
2. Navega al directorio del proyecto:
    ```bash
    cd Aplicando-principio-de-abierto-y-cerrado-OCP
    ```
3. Abre el proyecto con tu IDE preferido y ejecuta el programa.

## Autor

Cristianlede-15

## Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.
