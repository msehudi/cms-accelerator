
``` yaml
# list all the input OpenAPI files (may be YAML, JSON, or Literate- OpenAPI markdown)
input-file:
  - dynamics-swagger.json

csharp:
  output-folder: ./Client
  add-credentials: true
  override-client-name: DynamicsClient
  use-datetimeoffset: true 
  sync-methods: all 
  generate-empty-classes: true
  namespace: Gov.Lclb.Cllb.Interfaces
  azure-arm: false
  static-initializer: true
```
