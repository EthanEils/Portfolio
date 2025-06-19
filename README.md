# 🧑‍💻 Personal Portfolio (Next.js + .NET Aspire)

A full-stack portfolio project powered by **Next.js** for the frontend and **.NET Aspire** for orchestrating the backend. Deployed end-to-end to **Microsoft Azure**.

## 🧱 Tech Stack

- **Frontend**: Next.js (Tailwind CSS)
- **Backend**: .NET Aspire (Minimal APIs, Service Hosting)
- **DevOps**: GitHub Actions + Azure CLI + Container Registry
- **Infrastructure**: Azure App Services, Azure Container Apps, or Azure Static Web Apps
- **Orchestration**: .NET Aspire (Aspire.Hosting)

## 📁 Solution Structure
/frontend → Next.js frontend app
/backend → .NET backend API (Blog, Projects)
/services → Optional microservices
/PortfolioApp.AppHost → Aspire orchestration project (service config, diagnostics)
/infrastructure → Azure IaC (Bicep or Terraform)
/.github → GitHub Actions for CI/CD