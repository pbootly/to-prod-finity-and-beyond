# Zero to production in many languages!

A repository of the same application _attempting_ to follow the excellent steps in the book [Zero To Production In Rust](https://www.zero2prod.com/index.html) by [Luca Palmieri](https://www.lpalmieri.com/) which I wholly reccomend to focus on important aspects of developing software for production readiness. 

_The intent with this repository is to act as reference for specific setup for a language, with a repeated application pattern._

## Expected application completeness:

- [ ] **User subscription endpoint** – Accept requests to subscribe 
- [ ] **Validation of input** – Ensure email is valid, reject malformed requests
- [ ] **Persistence** – Store subscriptions in a postgres database 
- [ ] **Migrations / schema management** – Handle changing database schema safely
- [ ] **Unit tests for domain logic** – Verify rules and invariants of core models
- [ ] **Integration tests** – Test the system end-to-end, including database interactions
- [ ] **Property-based tests** (addition) – Check that core rules hold for a wide range of inputs
- [ ] **Health check endpoint** – Simple endpoint to verify the service is running
- [ ] **Configuration management** – Separate environment configs (development, production)
- [ ] **Observability / Logging** – Track requests, errors, and important events
- [ ] **Error handling / graceful failures** – Return meaningful errors for invalid inputs or system failures
- [ ] **Dockerization** – Containerize the service for consistent environments
- [ ] **Local development orchestration** – Use docker-compose to run DB and service locally
- [ ] **CI / CD setup** – Automate tests, build, deploy pipeline
- [ ] **API documentation / description** – Swagger or similar for endpoint clarity
- [ ] **Metrics / Monitoring** – Track basic usage or performance metrics

## Contributing

This isn't that serious, but take a language you want to try this in, update the below table - and if you want a stab of a language yourself that's already done - just underscore the folder with your username. I.e. dotnet_pbootly

| Language | Status | Author |
|----------|--------|--------|
| Rust     | ✅     | [Luca Palmieri -  “Zero to Production”](https://www.zero2prod.com/index.html) |
| C#       | WIP    | [pbootly](https://github.com/pbootly)|
| Python   |        |        |
| Go       |        |        |
| Java     |        |        |

