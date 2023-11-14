# Claw
一個操作機制上十分簡單(只有左鍵),但關卡難度極高的小遊戲
玩家需要運用射出的鉤爪移動,最後到達目的地
(這個遊戲的美術風格部分還沒有想法,所以先以完成遊戲本體邏輯及測試關卡可玩性為主)
## 打開遊戲後的畫面:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/6ce85e7e-2d45-4e2c-b666-4d9e2ae3d070)

## 關卡選擇畫面:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/3002d6e5-21cf-42f3-af15-27aeeec86e43)

## 關卡內部畫面:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/50c352d8-85a4-46ac-8f99-762d72d69878)
- 進入關卡後,計時器便會開始計時,在玩家重試或死掉時重置
- 畫面中心的白色方塊是玩家,玩家可以按下左鍵射出爪子,爪子在碰到白色的牆壁時會吸在上面,並且將玩家拉向該處
- 玩家上方的黃色區域為終點,我們的目標就是讓玩家到達那裡,當玩家碰到終點區時,計時器便會停止並顯示完成的時間

## 暫停畫面(按ESC鍵開啟/關閉):
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/4507c1b5-39b9-44db-ae56-d67028d9b5de)
- Continue為繼續關卡
- Retry會重置關卡並重新計時
- Leave會回到選擇關卡處
- 暫停時計時器也會暫停計時

## 爪子:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/40599ee0-443e-457d-ac34-03939bca9061)
- 畫面上的灰色長方體代表爪子,它在碰到牆壁時會停下

## 箱子:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/a25bd5ae-fdf5-48dd-92a1-b70533e2e8f4)
- 玩家旁邊的褐色方形代表箱子,它會阻擋玩家的去路,玩家可以用自己去推它,或是射爪子去推它(爪子不會附著在上面)

## 風扇&風:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/61e02d8e-6918-4aa6-ad89-e3af86d65aad)
- 青藍色的區域是風,它會將一切能動的東西(玩家,箱子,甚至射出的爪子及之後要加入的任何能動的東西...)吹向某個方向,風向及風速都使可以調整的,也不一定要有風扇存在
- 青藍色下方的藍色長條是風扇,玩家和箱子可以站在上面,但爪子碰到它時會消失

## 死亡區域:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/96877baa-40ac-49ae-8e5d-a4e0f28b1ea2)
- 玩家正上方的紅色長條是死亡區域,當玩家碰到死亡區域時,便會失敗並重置關卡
- 下面那條超長的橫條也是
- 跟箱子一樣,爪子碰到時不會附著也不會消失,因此也可以改變爪子的走向

## 目的地:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/1c5255b0-2af9-45c0-bdd3-ba9c082cb89b)

## 過關畫面:
![image](https://github.com/XorrrroX/ClawGame/assets/107466847/7fb35d61-8ea2-4dc2-b350-8084f8804138)
- retry可以重置關卡
- back會回到選關卡的地方

## 小功能:
- 滑鼠滾輪可以調整鏡頭大小
    ![image](https://github.com/XorrrroX/ClawGame/assets/107466847/d5e2af29-3903-480e-96c4-624eb658490a)
## 關卡設計理念:
關卡原則上會有多種過法,一種是相對簡單的過法,而另一種是可以抄近路的快速過法,但會用到一些特殊的技巧,且難度比較高,給想挑戰最快紀錄的玩家挑戰
