# ContactManager_ZBW

## Gruppenmitglieder
- Caner Kaya
- Oliver Füllemann
- Alec Stäheli
- Valent Zefi

## Beschreibung

ContactManager_ZBW ist eine Anwendung zur Verwaltung von Kontaktdaten. Die Anwendung ermöglicht das Hinzufügen, Bearbeiten und Löschen von Kontakten, und bietet eine benutzerfreundliche Oberfläche zur Verwaltung und Organisation von Kontaktinformationen.

## Features

- **Kontakt hinzufügen**: Fügen Sie neue Kontakte mit verschiedenen Details wie Name, Telefonnummer und E-Mail-Adresse hinzu.
- **Kontakt bearbeiten**: Ändern Sie bestehende Kontakte, um aktuelle Informationen zu reflektieren.
- **Kontakt löschen**: Entfernen Sie Kontakte, die nicht mehr benötigt werden.
- **Suchfunktion**: Finden Sie Kontakte schnell durch eine leistungsstarke Suchfunktion.
- **Kontaktliste anzeigen**: Zeigen Sie alle Kontakte in einer übersichtlichen Liste an.

## Installation

Folgen Sie diesen Schritten, um die Anwendung lokal auf Ihrem Computer zu installieren:

1. **Klonen Sie das Repository:**

   ```bash
   git clone https://github.com/Ferocious17/ContactManager_ZBW.git

2. **Build des Projekts im Visual Studio**
Das Projekt muss gebaut werden, sodass die Nuget-Pakages vom Entity-Framework heruntergeladen sind. Diese sind für das einrichten der Datenbank notwendig.

3. **Datenbank einrichten**
    1. Datenbank auf dem localhost:3306 laufen haben (SQL Server muss laufen)
    2. Öffnen der PackageManager Konsole im Visual Studio (normalerweise im linken unteren Bereich des Fensters)
    3. In das Verzeichnis mit der .csproj-Datei navigieren
    4. Folgenden Command ausführen: dotnet ef database update
    5. Nun sollten sie auf ihrem DB-Server die Datenbank "contactmanager" zur Verfügung haben.
    6. Folgendes SQL Statement ausführen:

    use contactmanager;
    Insert into department 
    VALUES (1, 'HR'), (2, 'IT'), (3, 'GL'), (4, 'Produktion'), (5, 'Verkauf'), (6, 'Finanzen'), (7, 'Jurisitsche Abteilung');

4. **Login**
Die Logindaten sind "admin" "admin" #security