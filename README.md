# Parcial 3 - Herramientas de Programación Aplicada III

---

## Tecnologías Utilizadas

| Tecnología | Versión / Tipo |
| :--- | :--- |
| Lenguaje | C# |
| Entorno de Desarrollo | Visual Studio Community 2026 |
| Base de Datos | MySQL |
| Gestor de Base de Datos | MySQL Workbench |
| Biblioteca JSON | Newtonsoft.Json |
| Biblioteca de Seguridad | BCrypt.Net-Next |
| Conector MySQL | MySql.Data |
| Control de Versiones | Git & GitHub |

---

## Estructura del Proyecto

| Carpeta / Archivo | Descripción |
| :--- | :--- |
| **Parcial3_P1/** | Implementación de una clase abstracta y uso de herencia y polimorfismo. |
| **Parcial3_P2/** | Conversión de objetos C# a formato JSON utilizando Newtonsoft.Json. |
| **Parcial3_P3/** | Sistema de autenticación utilizando BCrypt y MySQL. |
| **parcial3.sql** | Respaldo de la base de datos utilizada en la Parte 3. |

---

## Configuración de la Base de Datos

Importar el archivo:

```text
parcial3.sql
```

utilizando MySQL Workbench.

Posteriormente actualizar la cadena de conexión ubicada en:

```text
Conexion.cs
```

según la configuración local del servidor MySQL.

Ejemplo:

```csharp
Server=localhost;
Database=parcial3;
Uid=root;
Pwd=TU_PASSWORD;
```

---

## Datos del Estudiante

| Dato | Información |
| :--- | :--- |
| Nombre | Greisy Coronado |
| Curso | Herramientas de Programación Aplicada III |
| Instructor | Ing. Irina Fong |
| Período Académico | II Semestre 2026 |

---
