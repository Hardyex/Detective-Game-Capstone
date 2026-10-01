# Detective-Game-Capstone
2D Detective Adventure Game


graph TD
    Root[Detective-Game-Capstone] --> Assets[2D_Detective_Game/Assets]
    Assets --> ProjectFolder[_Project]
    
    ProjectFolder --> Art[Art]
    Art --> Background[Background]
    Art --> Characters[Characters]
    Art --> UI[UI]
    
    ProjectFolder --> Prefabs[Prefabs]
    ProjectFolder --> Scenes[Scenes]
    
    ProjectFolder --> SO[ScriptableObjects]
    SO --> Case[Case]
    SO --> Dialogues[Dialogues]
    SO --> Evidences[Evidences]
    SO --> Statements[Statements]
    
    ProjectFolder --> Scripts[Scripts]
    Scripts --> Core[Core / GameManager]
    Scripts --> Deduction[Deduction]
    Scripts --> Dialogue[Dialogue]
    Scripts --> Investigation[Investigation]
    Scripts --> Notebook[Notebook]
