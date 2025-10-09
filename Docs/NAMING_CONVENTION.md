# Naming Convention for C# / Unity Projects

This document defines naming standards for all C# code in our Unity projects.  
We follow Microsoft’s **Identifier Names** guidelines:  
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names


---

## 📘 Guiding Principle  
All identifiers should be named in such a way that code is readable, consistent, and predictable. We follow the Microsoft C# naming rules unless overridden for project-specific reasons.

---

## ✔ Identifier Rules

| Identifier Type | Naming Style | Examples |
|------------------|--------------|----------|
| **Namespaces** | PascalCase | `MyCompany.Game.Module` |
| **Classes / Structs / Enums** | PascalCase | `PlayerController`, `EnemyState` |
| **Interfaces** | PascalCase with `I` prefix | `IInputHandler`, `IEnemy` |
| **Methods / Properties / Events** | PascalCase | `MovePlayer()`, `Health`, `OnPlayerDeath` |
| **Public Fields / Variables / Parameters** | camelCase | `speed`, `playerHealth`, `maxSpeed` |
| **Private Fields / Variables / Parameters** | _camelCase | `_speed`, `_playerHealth`, `_maxSpeed` |
| **Prefap Fields / Variables / Parameters** | pp_camelCase | `pp_character`, `pp_quickButton`|
| **Constants / static readonly fields** | ALL_CAPS | `MAXHP`, `MAXMP` |
| **Enum Members** | PascalCase | `Idle`, `Attack`, `Defend` |

---

## 🧷 Project-Specific Overrides / Notes

| Case | Solution |
|------------------|--------------|
| **Private fields exposed in inspector**  | Use `[SerializeField] private float _moveSpeed;` (_camelCase). |
| **Public fields hide in inspector**  | Use `[HideInInspector] public float moveSpeed;` (camelCase). |

- **Avoid underscores** in names unless required by external API.  
- **Avoid prefixes** like `m_` or `s_` — they deviate from the Microsoft guideline.  
- **Enums** should use PascalCase for both the enum name and members.

---

## 📎 External Reference  
All devs should read the **Identifier Names** section from Microsoft docs:  
https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names

That document is considered canonical. If it differs from this guide, Microsoft’s version wins.

---

_Maintained by: TaniaFelidae_  
_Last updated: 2025-10-09_  
