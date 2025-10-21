# 📚 Andyteca de Libros

Una plataforma moderna de lectura digital inspirada en Netflix, desarrollada con ASP.NET Core Razor Pages.

## 🚀 Características

- **🎨 Diseño Moderno**: Interfaz oscura con degradados y efectos visuales
- **📱 Responsive**: Adaptable a todos los dispositivos  
- **📚 Gestión de Biblioteca**: Organiza tus libros por géneros y autores
- **⭐ Sistema de Reseñas**: Califica y comenta tus lecturas
- **🎯 Recomendaciones Personalizadas**: Descubre nuevos libros según tus gustos
- **📖 Listas de Lectura**: Crea y gestiona tus propias listas

## 🛠️ Tecnologías Utilizadas

- **Backend**: ASP.NET Core 8.0
- **Frontend**: Bootstrap 5, HTML5, CSS3
- **Lenguaje**: C#
- **Framework**: Razor Pages
- **Iconos**: Bootstrap Icons

markdown
## 📦 Estructura del Proyecto
Pages/
├── Index.cshtml # Página principal
├── Libros/ # Catálogo de libros
│ ├── Index.cshtml # Lista de todos los libros
│ └── Detalle.cshtml # Detalle de libro individual
├── MisLibros/ # Biblioteca personal
│ └── Index.cshtml
├── ListasLectura/ # Gestión de listas
│ └── Index.cshtml
├── Resenias/ # Sistema de reseñas
│ └── Index.cshtml
├── Recomendaciones/ # Recomendaciones personalizadas
│ └── Index.cshtml
├── Generos/ # Libros por género
│ └── Index.cshtml
├── Autores/ # Catálogo de autores
│ └── Index.cshtml
└── Contacto.cshtml # Formulario de contacto

## 🎨 Paleta de Colores

- **Primario**: `#e50914` (Rojo Netflix)
- **Secundario**: `#ffd700` (Dorado)
- **Acento**: `#4dabf7` (Azul claro)
- **Fondo**: Degradado de `#0c0c0c` a `#2d2d2d`
- **Texto**: `#ffffff`

## ⚙️ Requisitos Previos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 o Visual Studio Code
- Git

## 🚀 Instalación y Ejecución

1. **Clonar el repositorio**
   ```bash
   git clone https://github.com/tu-usuario/andyteca.git
   cd andyteca
