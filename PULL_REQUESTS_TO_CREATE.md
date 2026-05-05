# Pull requests для створення в GitHub

`gh` у цьому середовищі недоступний, тому pull requests потрібно створити вручну після публікації гілок. Не підставляй вигадані номери: після створення GitHub issues заміни `N` у `Closes #N` на реальний номер відповідного issue.

## PR 1

**Назва PR:** Remove schema creation from tournaments form

**Branch:** `fix/issue-1-remove-schema-from-ui`

**Issue, який закриває:** `Схема бази даних створюється у TournamentsForm`

**Опис змін:**

- Прибрано `CREATE TABLE IF NOT EXISTS` з `TournamentsForm.LoadTournaments`.
- Відповідальність за створення таблиць залишається в `DB.CreateDB`.
- Форма тепер тільки читає і показує турніри.

**Текст для опису PR:**

```md
Closes #N
```

## PR 2

**Назва PR:** Store match ids in tournament match list

**Branch:** `fix/issue-2-store-match-id-in-list`

**Issue, який закриває:** `Оновлення рахунку залежить від тексту ListBox`

**Опис змін:**

- `LoadMatches` читає `id` матчу з бази.
- У `ListBox` додається об'єкт `MatchListItem`, який зберігає `Id` і текст для показу.
- Рахунок оновлюється через `WHERE id = @id`, без парсингу відображуваного рядка.

**Текст для опису PR:**

```md
Closes #N
```

## PR 3

**Назва PR:** Trim entity name inputs before saving

**Branch:** `fix/issue-3-trim-text-inputs`

**Issue, який закриває:** `Поля назв приймають пробіли як валідне значення`

**Опис змін:**

- Перед перевіркою і записом обрізаються пробіли в назвах команд, турнірів і гравців.
- Значення, які після `Trim()` стали порожніми, не записуються в базу.
- У базу передається очищений текст.

**Текст для опису PR:**

```md
Closes #N
```

## Ручні команди для публікації гілок

```powershell
git push -u origin main
git push -u origin fix/issue-1-remove-schema-from-ui
git push -u origin fix/issue-2-store-match-id-in-list
git push -u origin fix/issue-3-trim-text-inputs
```
