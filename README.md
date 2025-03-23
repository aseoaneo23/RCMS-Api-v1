
🏁 RCMS - Race Car Management System 🚗  
RCMS es una API desarrollada en ASP.NET 9.0 que permite gestionar piezas, distribuidores y otros elementos relacionados con el mundo de las carreras de coches. Esta aplicación está diseñada para facilitar la administración de inventarios, proveedores y materiales necesarios en competiciones automovilísticas.

🛠️ Tecnologías Utilizadas
- ASP.NET Core 9.0 🖥️
- Entity Framework Core 🗄️
- C# 🔵
- SQL Server 🗃️
- Swagger 📄 (Documentación de la API)
- Git 🐙 (Control de versiones)

🌟 Características Principales
- Gestión de Piezas 🧩: Registra y administra piezas de coches de carreras (motores, neumáticos, frenos, etc.).

- Distribuidores 🚚: Mantén un registro de proveedores y distribuidores de piezas.

- Inventario 📦: Controla el stock de piezas y materiales.

- Categorías 🏷️: Organiza las piezas por categorías (motor, chasis, electrónica, etc.).

API RESTful 🌐: Endpoints bien definidos para integración con otros sistemas.

🚀 Cómo Empezar

Requisitos Previos
- .NET 9.0 SDK 📦
- SQL Server 🗃️
- Git 🐙 (opcional)

Instalación
1. Clona el repositorio:

   	bash  
   	git clone https://github.com/tuusuario/RCMS.git  
2. Navega al directorio del proyecto:

   	bash  
   	cd RCMS  
3. Restaura las dependencias de NuGet:

   	bash  
   	dotnet restore  
4. Configura la base de datos:

- Asegúrate de tener SQL Server instalado y en ejecución.

- Actualiza la cadena de conexión en appsettings.json.

- Ejecuta las migraciones:

  	bash  
  	dotnet ef database update  
5. Ejecuta la aplicación:

   	bash
   	dotnet run --project src/RCMS.WebApi  

📚 Documentación de la API  
La API está documentada con Swagger. Una vez que la aplicación esté en ejecución, puedes acceder a la documentación en:

http://localhost:5000/swagger

🗂️ Estructura del Proyecto

RCMS/  
├── src/  
│   ├── RCMS.Domain/              # Capa de Dominio (entidades y lógica de negocio)  
│   ├── RCMS.Application/         # Capa de Aplicación (casos de uso y servicios)  
│   ├── RCMS.Infrastructure/      # Capa de Infraestructura (base de datos, repositorios)  
│   └── RCMS.WebApi/              # Capa de Presentación (controladores y endpoints)  
│  
└── tests/                        # Pruebas unitarias y de integración  
├── RCMS.Domain.Tests/  
├── RCMS.Application.Tests/  
└── RCMS.WebApi.Tests/

📝 Endpoints Principales

Piezas (Parts) 🧩
- GET /api/parts: Obtener todas las piezas.

- GET /api/parts/{id}: Obtener una pieza por ID.

- POST /api/parts: Crear una nueva pieza.

- PUT /api/parts/{id}: Actualizar una pieza existente.

- DELETE /api/parts/{id}: Eliminar una pieza.

Distribuidores (Suppliers) 🚚
- GET /api/suppliers: Obtener todos los distribuidores.

- GET /api/suppliers/{id}: Obtener un distribuidor por ID.

- POST /api/suppliers: Crear un nuevo distribuidor.

- PUT /api/suppliers/{id}: Actualizar un distribuidor existente.

- DELETE /api/suppliers/{id}: Eliminar un distribuidor.

Categorías (Categories) 🏷️

- GET /api/categories: Obtener todas las categorías.

- GET /api/categories/{id}: Obtener una categoría por ID.

- POST /api/categories: Crear una nueva categoría.

- PUT /api/categories/{id}: Actualizar una categoría existente.

- DELETE /api/categories/{id}: Eliminar una categoría.


📄 Licencia  
Este proyecto está bajo la licencia MIT. Para más detalles, consulta el archivo LICENSE.

✉️ Contacto  
Si tienes alguna pregunta o sugerencia, no dudes en contactarme:

Email: seoanedeoisantonio@gmail.com 📧

GitHub: @aseoane23🐙

¡Gracias por usar RCMS! 🏎️💨