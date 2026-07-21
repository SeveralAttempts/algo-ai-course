# Algorithms Learning

Долгосрочная система изучения алгоритмов и структур данных на C#. Репозиторий одновременно служит учебником, лабораторией, журналом прогресса и переносимым состоянием AI-наставника.

## Как начать

1. Выполните действие из [`00_Roadmap/Next_Action.md`](00_Roadmap/Next_Action.md).
2. Для продолжения в новой сессии напишите: **«Давай продолжим»**.
3. Код проверяется командами `dotnet restore`, `dotnet build` и `dotnet test`.
4. Бенчмарки запускаются отдельно: `dotnet run -c Release --project benchmarks/Algorithms.Benchmarks`.

Первая учебная тема будет выбрана после стартовой диагностики. Диагностика не исключает фундаментальные темы: она определяет глубину объяснений и количество практики.

## Навигация

- [`00_Roadmap/Curriculum.md`](00_Roadmap/Curriculum.md) — полная траектория.
- [`00_Roadmap/Current_State.md`](00_Roadmap/Current_State.md) — текущее состояние.
- [`00_Roadmap/Current_Focus.md`](00_Roadmap/Current_Focus.md) — текущий фокус.
- [`00_Roadmap/Recovery_State.md`](00_Roadmap/Recovery_State.md) — восстановление на другой машине.
- [`Exercises/In_Progress/DIAG-001_Initial_Assessment.md`](Exercises/In_Progress/DIAG-001_Initial_Assessment.md) — активная диагностика.
- `src/`, `tests/`, `benchmarks/` — реализации, тесты и измерения.

Материалы разделены по этапам `01_...`–`30_...`. Решения пользователя хранятся в `Solutions/User`, эталонные разборы — в `Solutions/Reference` и не создаются до самостоятельной попытки.

> На файловых системах Windows каталоги `Tests/tests` и `Benchmarks/benchmarks` не могут различаться только регистром. Поэтому категории тестов (`Unit`, `PropertyBased`, `Adversarial` и другие) и тестовые проекты объединены под `tests/`, а benchmark-материалы и проект — под `benchmarks/`. Это сохраняет переносимость solution на регистрозависимые системы.
