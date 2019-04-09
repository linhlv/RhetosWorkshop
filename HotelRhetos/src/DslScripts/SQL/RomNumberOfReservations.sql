SELECT
    r.ID,
    NumberOfReservations = COUNT(rs.ID)
FROM
    HotelRhetos.Room r
    LEFT JOIn HotelRhetos.Reservations rs ON rs.RoomID = r.ID
GROUP BY
    r.ID
    /*
HAVING COUNT(rs.ID) > 0
*/