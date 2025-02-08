# 🌦️ FastAPI Weather API  

API para obtener información meteorológica usando FastAPI y OpenWeather.

---

## 📂 Estructura del Proyecto  

```bash
fastapi_weather/
│── app/
│   ├── api/
│   │   ├── endpoints/
│   │   │   ├── weather.py      # Endpoint para obtener el clima
│   │   │   ├── location.py     # Endpoint para obtener ubicaciones
│   │   │   ├── __init__.py
│   │   ├── __init__.py
│   ├── core/
│   │   ├── config.py           # Configuración y variables de entorno
│   │   ├── __init__.py
│   ├── services/
│   │   ├── weather_service.py  # Lógica para consultar clima
│   │   ├── location_service.py # Lógica para buscar ubicaciones
│   │   ├── __init__.py
│   ├── main.py                 # Punto de entrada de la API
│   ├── models/
│   │   ├── weather.py
│   │   ├── __init__.py
│   ├── schemas/
│   │   ├── weather.py          # Esquema de respuesta del clima
│   │   ├── location.py         # Esquema de respuesta de ubicaciones
│   │   ├── __init__.py
│   ├── __init__.py
│── .env                        # Variables de entorno (API Key)
│── requirements.txt            # Dependencias del proyecto
│── README.md                   # Documentación
