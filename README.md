# **Shepherd Observer 🐑**  
A gamified Unity project demonstrating the **Observer Pattern** using an analogy of sheep.  

---

## **📌 What is the Observer Pattern?**  
The **Observer Pattern** is a **behavioral design pattern** where:  
- A **Subject** maintains a list of **Observers**.  
- When the **Subject's state changes**, it **notifies** all observers.  
- This ensures **loose coupling** between objects.  

---

## **📝 How This Project Implements It**
| Component         | Role |
|------------------|------|
| **Mother Sheep** (SubjectClass) | **Subject**: Handles user input and notifies observers. |
| **Son & Daughter Sheep** (IMovement Implementers) | **Observers**: Follow the mother when notified. |
| **ManagerClass** | Manages observers and sends notifications. |
| **IMovement** | Defines the movement actions. |

---

## **🎮 How It Works**
![Shepherd Observer-GIF](https://github.com/user-attachments/assets/e8807ea9-b71d-4447-b92d-d895215a6747)
### **1️⃣ Mother Sheep Moves**  
The **player controls** the **Mother Sheep** using **keyboard** or **UI buttons**.  

```csharp
private void Update()
{
    if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
    {
        OnJumpButtonClicked();
    }
    if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
    {
        OnRightButtonClicked();
    }
    if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
    {
        OnLeftButtonClicked();
    }
}
```
---

### **2️⃣ Observers Follow**  
Whenever the **Mother Sheep moves**, the **ManagerClass** **notifies** all observers (Son & Daughter).  

```csharp
public void MakeAllObserversMoveRight()
{
    foreach (var observer in m_MovementList)
    {
        observer.MoveRight();
    }
}
```

---

### **3️⃣ Decoupled Interaction**  
Observers **don't directly interact** with the mother; they just **respond to notifications**.  

```csharp
public class Son : MonoBehaviour, IMovement
{
    public void MoveRight()
    {
        Debug.Log("Son is moving right");
    }
}
```

---

## **🛠️ Project Structure**
### **1️⃣ SubjectClass (Mother Sheep)**
- **Handles user input** (buttons/keys).  
- **Moves itself** and **notifies all observers**.  

```csharp
public class SubjectClass : MonoBehaviour
{
    [SerializeField] ManagerClass m_managerClass;

    private void OnRightButtonClicked()
    {
        Debug.Log("Mother is moving right");
        m_managerClass.MakeAllObserversMoveRight();
    }
}
```

---

### **2️⃣ ManagerClass (Observer Manager)**
- **Maintains a list** of all observers.  
- **Notifies them** when an action occurs.  

```csharp
public class ManagerClass : MonoBehaviour
{
    private List<IMovement> m_MovementList = new List<IMovement>();

    public void AddObserver(IMovement observer)
    {
        if (!m_MovementList.Contains(observer))
        {
            m_MovementList.Add(observer);
        }
    }

    public void MakeAllObserversJump()
    {
        foreach (var observer in m_MovementList)
        {
            observer.Jump();
        }
    }
}
```

---

### **3️⃣ Son & Daughter (Observers)**
- **Implement the `IMovement` interface**.  
- **React to subject’s notifications**.  

```csharp
public class Daughter : MonoBehaviour, IMovement
{
    public void Jump()
    {
        Debug.Log("Daughter is jumping");
    }

    public void MoveLeft()
    {
        Debug.Log("Daughter is moving left");
    }

    public void MoveRight()
    {
        Debug.Log("Daughter is moving right");
    }
}
```

---

### **4️⃣ IMovement (Interface)**
Defines movement actions for **all observers**.  

```csharp
public interface IMovement
{
    void Jump();
    void MoveRight();
    void MoveLeft();
}
```

---

## **🚀 Code Flow**
### **1️⃣ Observers Register Themselves**  
When the game starts, **Son and Daughter register** themselves with **ManagerClass**.  

```csharp
void Start()
{
    m_managerClass.AddObserver(this);
}
```

---

### **2️⃣ User Input (Mother Moves)**
When a button or key is pressed, **SubjectClass moves the Mother Sheep and notifies all observers**.  

```csharp
private void OnJumpButtonClicked()
{
    Debug.Log("Mother is jumping");
    m_managerClass.MakeAllObserversJump();
}
```

---

### **3️⃣ Observers Respond**
Each observer (**Son & Daughter**) executes the **corresponding movement**.  

```csharp
public void Jump()
{
    Debug.Log("Son is jumping");
}
```
---
## **❓ Need Help?**
If you have any **questions**, feel free to **open an issue**.  
