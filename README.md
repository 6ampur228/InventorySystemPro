# Inventory System (Unity, UI Toolkit, MVC)

Модульная, асинхронная, масштабируемая система инвентаря с использованием современных подходов и инструментов Unity. Подходит для проектов с акцентом на чистую архитектуру и расширяемость. Цель проекта показать мои знания на практике с такими вещами как: MVC, UIToolkit, New Input System, async/await, SO, паттерны(Builder, Strategy)

---

## Основные фичи

- MVC-архитектура: Чёткое разделение `Model`, `View`, `Controller`
  - `InventoryModel` и `Slot` — отвечает за данные и бизнес-логику.
  - `InventoryView` и `SlotView` — визуальное представление.
  - `InventoryController` — связывает модель и вью.

- Асинхронная инициализация UI с использованием `UniTask` (`async/await`)
  - Используется в `InventoryView.InitializeViewAsync`.

- Собственные расширения `VisualElement` для декларативного построения UI
  - Файл: `VisualElementExtensions.cs`
  - Упрощает создание иерархии UI, повышает читаемость кода.
 
- UI Toolkit + USS: полностью сгенерированная иерархия UI через C# — без UXML.
  - `VisualElementExtensions.cs` предоставляет удобные методы `CreateChild`, `AddClass`, `AddTo`.
  - Вся разметка строится скриптом (`InventoryView.cs`).

- New Input System:
  - Настроено через `InventoryInputHandler.cs`
  - `A / D` — переключение слотов (`ChangeSlotPressed`)
  - `E` — использование предмета (`UseItemPressed`)

- ScriptableObject-архитектура предметов с отделением поведения от данных:
  - `Item.cs` содержит данные и поведение через `ItemBehaviorBase`
  - `HealBehavior.cs` и прочии реализует конкретное поведение
  - Использован паттерн Strategy

- `ItemUseContext` + Builder Pattern
  - Контекстный класс для передачи информации в поведение предмета
  - Использует паттерн Builder для гибкой конфигурации (`SetPlayer`, `SetTarget`, и т.д.)
  - Класс: `ItemUseContext.cs`


 
