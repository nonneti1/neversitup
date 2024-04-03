Latest project folder structure
```bash
.
└── api-service/
    ├── src/
    │   ├── client-api/
    │   │   ├── api-a/
    │   │   │   └── index.ts
    │   │   └── api-b/
    │   │       └── index.ts
    │   ├── server-api/
    │   │   ├── api-c/
    │   │   │   └── index.ts
    │   │   └── api-d/
    │   │       └── index.ts
    │   ├── common/
    │   │   ├── enum/
    │   │   │   ├── base.ts
    │   │   │   └── errorCode.ts
    │   │   └── interface/
    │   │       ├── api/
    │   │       │   ├── api-a.ts
    │   │       │   ├── api-b.ts
    │   │       │   ├── api-c.ts
    │   │       │   └── api-d.ts
    │   │       └── base/
    │   │           └── player.ts
    │   ├── auth/
    │   │   └── CallerAuthorizer
    │   └── utils/
    │       ├── libs
    │       ├── helper.ts
    │       └── logger.ts
    ├── .env
    ├── jest.config.js
    ├── tsconfig.json
    ├── package.json
    ├── .gitignore
    ├── serverless.yml
    └── .gitlab-ci.yml
```
