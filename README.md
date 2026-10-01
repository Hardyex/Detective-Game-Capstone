# Detective-Game-Capstone
2D Detective Adventure Game

```mermaid
graph TD
    Root[Detective-Game-Capstone] --> Assets[2D_Detective_Game/Assets]
    Assets --> ProjectFolder[_Project]
    
    ProjectFolder --> Art[Art]
    Art --> Backgrounds[Backgrounds]
    Art --> Characters[Characters]
    Art --> UI[UI]
    
    ProjectFolder --> Prefabs[Prefabs]
    Prefabs --> DialogueBox[DialogueBox]
    Prefabs --> Investigation[Investigation]
    Prefabs --> Notebook[Notebook]
    
    ProjectFolder --> Scenes[Scenes]
    Scenes --> MainMenu[MainMenu.unity]
    Scenes --> Chapter1[Chapter1.unity]
    
    ProjectFolder --> SO[ScriptableObjects]
    SO --> Cases[Cases]
    SO --> Dialogues[Dialogues]
    SO --> Evidences[Evidences]
    SO --> Statements[Statements]
    
    ProjectFolder --> Scripts[Scripts]
    Scripts --> Core[Core]
    Scripts --> Dialogue[Dialogue]
    Scripts --> InvestigationScript[Investigation]
    Scripts --> NotebookScript[Notebook]
    Scripts --> Deduction[Deduction]
