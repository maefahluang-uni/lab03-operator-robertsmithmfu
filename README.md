# Computer Programming - Operator and Expression
***อย่าลืมลง C# Dev Kitก่อนเริ่ม*** ทำแบบฝึกหัดนี้โดยแก้ไข run() ใน Program.cs (อยู่ในโฟลเดอร์ lab)

โปรแกรมนี้จะรับตัวเลขสองจำนวนเต็มจากผู้ใช้ 

จากนั้นจะทำการเปรียบเทียบและคำนวณ ดังนี้

1. ตรวจสอบว่าตัวเลขแรกมากกว่าตัวเลขที่สองหรือไม่
2. ตรวจสอบว่าตัวเลขแรกเป็นเลขคู่ (หารด้วย 2 ลงตัว) 
3. หาเศษเหลือจากการหารตัวเลขแรกด้วยตัวเลขที่สอง (ใช้เครื่องหมาย %)
4. แสดงผลลัพธ์บนหน้าจอ console ดังนี้
    - ตัวเลขทั้งสองเท่ากันหรือไม่? (ใช่/ไม่ใช่)
    - ตัวเลขแรกมากกว่าตัวเลขที่สองหรือไม่? (ใช่/ไม่ใช่)
    - ตัวเลขแรกเป็นเลขคู่หรือไม่? (ใช่/ไม่ใช่)
    - เศษเหลือจากการหารตัวเลขแรกด้วยตัวเลขที่สอง

ตัวอย่าง:
ถ้าผู้ใช้ป้อน 10 และ 5 ผลลัพธ์ที่ได้จะเป็น
```
Are the first and second numbers equal? No
Is the first number greater than the second number? Yes
Is the first number even? Yes
The remainder when the first number is divided by the second number is 0
```

## Running
โปรแกรมนี้สามารถรันผ่านปุ่ม run ด้านขวาบน หรือจาก terminal ด้วยคำสั่ง (เปิด Terminal ด้วย key Ctrl + Alt + `)

dotnet run --project lab/exercise-program.csproj


## Testing
ทดสอบโปรแกมก่อนส่งงาน โดยรันคำสั่งด้านล่าง ผ่าน Terminal
```
dotnet test test/test-program.csproj
```
ถ้าโปรแกรมรันได้ถูกต้องจะขึ้นสีเขียว พร้อมแสดง Passed!
ถ้าโปรแกรมรันได้ผิดจะขึ้นสีแดง พร้อมแสดง Failed! ให้ตรวจสอบข้อผิดพลาดในโปรแกรมจากข้อความ error ที่ได้พบ

**หลังจากทำแบบฝึกหัดเสร็จอย่าลืม Commit & Push**
































