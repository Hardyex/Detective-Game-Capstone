# Detective-Game-Capstone
2D Detective Adventure Game

graph LR
    Root[Detective-Game-Capstone] --> Assets[2D_Detective_Game/Assets]
    Assets --> ProjectFolder[_Project]
    
    subgraph Folders ["Thư mục chính (_Project)"]
        ProjectFolder --> Art[Art]
        ProjectFolder --> Prefabs[Prefabs]
        ProjectFolder --> Scenes[Scenes]
        ProjectFolder --> SO[ScriptableObjects]
        ProjectFolder --> Scripts[Scripts]
    end
    
    Art --> Backgrounds[Backgrounds]
    Art --> Characters[Characters]
    Art --> UI[UI]
    
    Prefabs --> DialogueBox[DialogueBox]
    Prefabs --> Investigation[Investigation]
    Prefabs --> Notebook[Notebook]
    
    Scenes --> MainMenu[MainMenu.unity]
    Scenes --> Chapter1[Chapter1.unity]
    
    SO --> Cases[Cases]
    SO --> Dialogues[Dialogues]
    SO --> Evidences[Evidences]
    SO --> Statements[Statements]
    
    Scripts --> Core[Core]
    Scripts --> Dialogue[Dialogue]
    Scripts --> InvestigationScript[Investigation]
    Scripts --> NotebookScript[Notebook]
    Scripts --> Deduction[Deduction]
