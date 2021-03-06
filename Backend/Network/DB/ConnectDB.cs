﻿using System;


namespace Backend.Network
{
    public partial class ConnectDB
    {
        string connStr = "Server=219.228.148.128; Port=5432; Username=postgres; Password=postgres; Database=mmorpg";
        string registerSQL = "INSERT INTO player (name,passwd) VALUES (@name,@passwd)";
        string logInSQL = "SELECT playerid FROM player WHERE name = @name AND passwd = @passwd";
        string GetPlayerAttriSQL = "SELECT * FROM player WHERE playerid = @playerid";
        string GetTreasureAttriSQL = "SELECT * FROM treasures";
        string GetMallSQL = "SELECT * FROM mall";
        string GetPackageSQL = "SELECT * FROM package WHERE playername = @playername";
        string UpdateTreasureNumSQL = "UPDATE package SET ownnum = @number WHERE playername = @playername AND treasurename = @treasurename";
        string UpdataSilverNumSQL = "UPDATE player SET silvernum = @silvernum WHERE name = @name";
        string GoldTransactionSQL = "BEGIN; UPDATE player SET goldnum = goldnum + @goldCoin WHERE name = @seller; UPDATE player SET goldnum = goldnum - @goldCoin WHERE name = @buyer; INSERT INTO package(playername, treasurename) VALUES(@buyer, @goods); DELETE FROM mall WHERE TreasureName = @goods; INSERT INTO trade (ItemName,SellerName,BuyerName,IsGold,Price,TradeTime) VALUES (@goods,@seller,@buyer,@IsGold,@goldCoin,@TradeTime); COMMIT ";
        string AddTradeSQL = "INSERT INTO trade (ItemName,SellerName,BuyerName,IsGold,Num,Price,TradeTime) VALUES (@ItemName,@SellerName,@BuyerName,@IsGold,@Num,@Price,@TradeTime)";
        string UpdateAttributeSQL = "UPDATE player SET speedvalue = @speedvalue, intelligencevalue = @intelligencevalue, attackvalue = @attackvalue, defensevalue = @defensevalue WHERE name = @name";
        string UpdateTreasureWearSQL = "UPDATE package SET wear = @wear WHERE playername = @playername AND treasurename = @treasurename";
        string DeleteFromPackageSQL = "Delete FROM package WHERE playername = @playername AND treasurename = @treasurename";
        string AddToMallSQL = "INSERT INTO mall(treasurename, price, ownername, isgold) VALUES (@treasurename, @price, @ownername, @isgold)";
        string GetChatHistorySQL = "SELECT fromwho,content FROM chatlog WHERE fromwho IN (@sender,@receiver) AND towho IN (@sender,@receiver) ORDER BY chattime DESC LIMIT @maxNum";
        string AddToPackageSQL = "INSERT INTO package(playername, treasurename, wear, ownnum) VALUES(@playername, @treasurename, false, 1)";
        string RemoveFromMallSQL = "Delete FROM mall WHERE ownername = @ownername AND treasurename = @treasurename";
        string SearchFriendSQL = "SELECT playerid FROM player WHERE name = @name";
        string AddFriendRequestSQL = "INSERT INTO friendrequest(fromname, toname) VALUES(@fromname, @toname)";
        string FindFriendsSQL = "SELECT playername2 FROM friends WHERE playername1 = @name";
        string FindRequestsSQL = "SELECT fromname FROM friendrequest WHERE toname = @name";
        string AddFriendSQL = "INSERT INTO friends(playername1, playername2) VALUES(@playername1, @playername2)";
        string DeleteFriendRequestSQL = "DELETE FROM friendrequest WHERE fromname = @fromname AND toname = @toname";
    }
}
