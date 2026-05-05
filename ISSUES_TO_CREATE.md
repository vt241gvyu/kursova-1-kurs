# Issues для створення в GitHub

`gh` у цьому середовищі недоступний, тому issues підготовлені локально. Після створення кожного issue в GitHub використай реальні номери issue у pull request описах.

## Issue 1: Схема бази даних створюється у TournamentsForm

### Проблема

Форма `TournamentsForm` під час завантаження турнірів виконує `CREATE TABLE IF NOT EXISTS`. Ініціалізація структури бази даних уже є в класі `DB`, тому UI-форма дублює відповідальність шару бази даних.

### Де знаходиться

- [FootballMatch/TournamentsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentsForm.cs#L16-L26)
- [FootballMatch/DB.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/DB.cs#L12-L28)

### Чому це проблема

Це порушує Single Responsibility Principle і Separation of Concerns: форма має показувати турніри, а не відповідати за створення таблиць. Також з'являється дублювання SQL-схеми.

### Очікуване виправлення

Прибрати створення таблиць з `TournamentsForm.LoadTournaments` і залишити відповідальність за схему бази даних у `DB.CreateDB`.

## Issue 2: Оновлення рахунку залежить від тексту ListBox

### Проблема

`TournamentDetailsForm` додає матчі в `ListBox` як звичайний текст, а під час оновлення рахунку парсить цей текст назад, щоб отримати дату, домашню і гостьову команду.

### Де знаходиться

- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L62-L70)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L116-L146)

### Чому це проблема

Це крихкий код і порушення KISS: зміна формату тексту або назва команди з пробілами може зламати оновлення рахунку. Бізнес-ідентифікація матчу не повинна залежати від відображуваного рядка.

### Очікуване виправлення

Зберігати в `ListBox` об'єкт із `Id` матчу та текстом для показу. Оновлювати рахунок за `id`, а не через парсинг рядка.

## Issue 3: Поля назв приймають пробіли як валідне значення

### Проблема

Деякі форми перевіряють введення через `Text == ""`. Через це рядок з пробілів проходить валідацію і може бути записаний у базу як назва команди, турніру або гравця.

### Де знаходиться

- [FootballMatch/AddTeamForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTeamForm.cs#L16-L26)
- [FootballMatch/AddTournamentForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/AddTournamentForm.cs#L16-L26)
- [FootballMatch/TeamDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TeamDetailsForm.cs#L47-L58)
- [FootballMatch/TournamentDetailsForm.cs](https://github.com/vt241gvyu/kursova-1-kurs/blob/main/FootballMatch/TournamentDetailsForm.cs#L158-L175)

### Чому це проблема

Це слабка валідація і порушення Fail Fast: програма пропускає некоректне значення, хоча має відхилити його до запису в базу.

### Очікуване виправлення

Використовувати `Trim()` перед перевіркою, відхиляти порожні після обрізання значення і записувати в базу вже очищений текст.
