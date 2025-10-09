## 🧠 Git Workflow & Branching Model

We adopt the **Gitflow / branching model** as described by nvie.com:  
https://nvie.com/posts/a-successful-git-branching-model/

### 📂 Branch Types & Purpose

| Branch | Purpose |
|--------|---------|
| `main` | Contains production-ready releases only. |
| `develop` | Integration branch for the next release. |
| `feature/<name>` | Branch off `develop` for a new feature. |
| `release/<version>` | Created when `develop` is ready for a release. |
| `bugfix/<name>` | Created when `develop` need bug fix |
| `experimental/<name>` | Branch off `any` to experiement on new feature. |

### 🛠 Workflow Rules

**Start new features from `develop`**:
   ```bash
   git checkout develop
   git pull
   git checkout -b feature/your-feature-name
