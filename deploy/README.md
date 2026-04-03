# Development Deploy

This repository is prepared for a two-container dev deploy:

- `backend` serves the ASP.NET Zero Web.Host application on `127.0.0.1:8081`
- `frontend` serves the React SPA on `127.0.0.1:8082`

The machine-level reverse proxy should route:

- `dev.pioneree.com` -> `http://127.0.0.1:8082`
- `api-dev.pioneree.com` -> `http://127.0.0.1:8081`

Run `docker-compose.dev.yml` from the repository root and provide `PIONEREE_CONNECTION_STRING` for the backend database.
