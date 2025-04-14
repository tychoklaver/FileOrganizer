# 📁 FileOrganizer

A simple C# console app that organizes files inside a selected folder within your user directory (HOME folder). Automatically groups files into categorized folders based on their extensions.

---

## 🚀 Features

- Automatically detects your HOME directory.
- Organizes files by type into subfolders:
  - `.docx`, `.pdf` → `Docs`
  - `.xlsx`, `.pptx` → `OfficeResources`
  - `.txt` → `TextFiles`
  - `.exe` → `Executables`
  - `.jpg`, `.jpeg`, `.png` → `Images`
  - Other files → `Rest`
- Skips:
  - `.zip` files
  - folders
  - existing destination files (no overwrite)

---

## 📂 Example Folder Structure

- `Documents/`
  - `Docs/`
    - `resume.docx`  
    - `report.pdf`  
  - `OfficeResources/`
    - `budget.xlsx`  
    - `slides.pptx`  
  - `Images/`
    - `photo.jpg`  
  - `TextFiles/`
    - `notes.txt`  
  - `Executables/`
    - `installer.exe`  
  - `Rest/`
    - `data.unknown`  

---

## 🛠️ How to Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download) if you haven't already.
2. Clone this repository:

   ```bash
   git clone https://github.com/tychoklaver/FileOrganizer.git
   ```

3. Navigate into the project folder:

   ```bash
   cd FileOrganizer
   ```

4. Run the application using:

   ```bash
   dotnet run
   ```

5. When prompted, enter a **relative path from your HOME folder**. For example:

   ```
   Documents
   ```

---

## 🧼 Notes

- The app does not currently handle nested folders or resolve file name conflicts.
- You can use this as a base and expand it with features like recursive organization, logging, or a GUI.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

Made with ❤️ by Tycho Klaver

