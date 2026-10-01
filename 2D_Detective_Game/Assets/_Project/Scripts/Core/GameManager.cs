using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    // Các trạng thái chính của game trinh thám
    public enum GameState
    {
        Dialogue,       // Đang đọc hội thoại / Visual Novel
        Investigation,  // Đang khám nghiệm hiện trường, click nhặt vật phẩm
        CrossExamination, // Đang đối chất, bóc mẽ lời khai (Press / Present)
        Notebook        // Đang mở sổ tay xem dữ liệu
    }

    public GameState CurrentState;

    private void Awake()
    {
        // Đảm bảo GameManager tồn tại duy nhất xuyên suốt các scene
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        // Khởi tạo trạng thái ban đầu khi vào game
        ChangeState(GameState.Dialogue);
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Game State changed to: " + CurrentState);
        
        // Sau này sẽ viết switch-case xử lý logic riêng cho từng trạng thái ở đây
    }
}