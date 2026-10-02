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
