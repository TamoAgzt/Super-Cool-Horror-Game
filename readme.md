# House Rules

1. [General Info](#1-general-info)
1. [Branches](#2-branches)
1. [Software](#3-software)

---

## 1. General info

- English for documentation, comments and variable names
- When adding a feature, ask another developer to review your changes and perform the merge. Reason is simple: we easily overlook our own mistakes. 
- Before making any changes, write down for yourself what you are changing and why. In case something goes wrong.
- Adding models can be pushed straight to development without a feature branch

## 2. Branches

| Branch name | Description                   |
| ----------- | ----------------------------- |
| main        | Fallback stable release       |
| development | Collection branch of features |
| feature\*   | All the individual components |

Feature branches have a special name formatted as such: FeatureName_YYYMMDD

Example branch names: TerrainConcept_20230722, EnemyAI_20230722, EnemyAI_Refinement_20230725

Feature branch naming: feature/{name of feature}
example: feature/Video_Upload

## 3. Software

- Unity 2021.3.25f1
- Visual Studio/Visual Studio Code
- Blender
