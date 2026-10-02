# ExampleMod

A C# example mod for **The Adventurer's Era**. Adds a test crystal
that drops from the test mob: 1–3 items with a 100% drop chance.

## Project structure

```text
src/                 # Source code
  ExampleMod.cs      # Entry point
  Resources/         # Items and their properties
assets/              # Icons and translations
SDK/                 # Game SDK, added manually
module.json          # Mod ID, name, version, and settings
ExampleMod.csproj    # Build settings
build.cmd            # Windows build script
build.sh             # Linux build script
```

## Build

Install the **.NET SDK** and extract a compatible game SDK into `SDK/`.
The API DLL must be located at:

```text
SDK/References/AdventurersEra.Modding.Api.dll
```

On **Windows**, run `build.cmd`. On **Linux**, run this from the project folder:

```sh
sh build.sh
```

Or build directly:

```sh
dotnet build ExampleMod.csproj -c Release
```

Output:

```text
dist/package/ExampleMod-1.0.0/   # Ready-to-install mod folder
dist/ExampleMod-1.0.0.zip        # Archive for distribution
```

The version comes from `module.json`. The game SDK is not included in the package;
add `SDK/` to `.gitignore`.

## Installation

Copy the built mod folder or extract the ZIP into `Mods` next to the game.
Check that `Mods/ExampleMod-1.0.0/module.json` exists, then restart the game.
When updating, replace the old mod folder with the new one.

---

# ExampleMod

Пример C#-мода для **The Adventurer's Era**. Добавляет тестовый кристалл,
который выпадает с тестового моба: 1–3 штуки с шансом 100%.

## Структура

```text
src/                 # Исходный код
  ExampleMod.cs      # Точка входа
  Resources/         # Предметы и их свойства
assets/              # Иконки и переводы
SDK/                 # SDK игры, добавляется вручную
module.json          # ID, название, версия и настройки мода
ExampleMod.csproj    # Настройки сборки
build.cmd            # Сборка на Windows
build.sh             # Сборка на Linux
```

## Сборка

Установи **.NET SDK** и распакуй совместимый SDK игры в папку `SDK/`.
DLL должна находиться по пути:

```text
SDK/References/AdventurersEra.Modding.Api.dll
```

На **Windows** запусти `build.cmd`. На **Linux** из папки проекта выполни:

```sh
sh build.sh
```

Или собери напрямую:

```sh
dotnet build ExampleMod.csproj -c Release
```

Результат:

```text
dist/package/ExampleMod-1.0.0/   # Готовая папка мода
dist/ExampleMod-1.0.0.zip        # Архив для публикации
```

Версия берётся из `module.json`. SDK в готовый пакет не входит;
добавь `SDK/` в `.gitignore`.

## Установка

Скопируй готовую папку или распакуй ZIP в `Mods` рядом с игрой.
Проверь путь `Mods/ExampleMod-1.0.0/module.json` и перезапусти игру.
При обновлении замени старую папку мода новой.
