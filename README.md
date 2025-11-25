# Prototype
โปรเจคร์นี้เป็นเกมแนว 2d side-scroll run and gun
ที่มีระบบหลักๆคือ
- ระบบ score
- ระบบ unlock level
- ระบบ Spawm 
- ระบบ Unlock skill

ได้ใช้ 2 pattern ในการแก้โดยมีการใช้ 
- command pattern 
- state pattern

โดยมีการใช้ command pattern กับระบบ unlock skill กับ unlock spawn
ส่วน state pattern ใช้กับ unlock level
โดยระบบเหล่านี้จะมี invoker เป็น Scoremanager
ส่วน unlock level ใช้เป็น state pattern

หลังจากการอัพเดททำให้ง่ายต่อการเพิ่มส่วนเสริมหรือระบบถ้าเป็น command pattern ก็สามารถได้เช่น event pattern 
หรือในส่วนของ state pattern ก็สามารถทำพวก player state (OnVenom OnBurn OnFreeze)
และหลังอัพเดททำให้บาง script กิน performance ของเครื่องน้อยลงอย่างเช่น Scoremanager ที่เรียกตรวจ score
ใน Update() ตลอดเวลา ก็เปลี่ยนมาเรียกแค่เฉพาะตอนที่แต้มถึงอย่างเดียว
