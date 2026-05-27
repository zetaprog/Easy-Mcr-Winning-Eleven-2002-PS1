Public Class PlayerStats

    ' Relación con Players.Id
    Public Property PlayerId As Integer

    ' ATTACKING
    Public Property Crossing As Integer
    Public Property Finishing As Integer
    Public Property HeadingAccuracy As Integer
    Public Property ShortPassing As Integer
    Public Property Volleys As Integer

    ' SKILL
    Public Property Dribbling As Integer
    Public Property Curve As Integer
    Public Property FKAccuracy As Integer
    Public Property LongPassing As Integer
    Public Property BallControl As Integer

    ' MOVEMENT
    Public Property Acceleration As Integer
    Public Property SprintSpeed As Integer
    Public Property Agility As Integer
    Public Property Reactions As Integer
    Public Property Balance As Integer

    ' POWER
    Public Property ShotPower As Integer
    Public Property Jumping As Integer
    Public Property Stamina As Integer
    Public Property Strength As Integer
    Public Property LongShots As Integer

    ' MENTALITY
    Public Property Aggression As Integer
    Public Property Interceptions As Integer
    Public Property AttackPosition As Integer
    Public Property Vision As Integer
    Public Property Penalties As Integer
    Public Property Composure As Integer

    ' DEFENDING
    Public Property DefensiveAwareness As Integer
    Public Property StandingTackle As Integer
    Public Property SlidingTackle As Integer

    ' GOALKEEPING
    Public Property GKDiving As Integer
    Public Property GKHandling As Integer
    Public Property GKKicking As Integer
    Public Property GKPositioning As Integer
    Public Property GKReflexes As Integer

    ' REPUTATION INTERNATIONA
    Public Property RepInternational As Integer
End Class

