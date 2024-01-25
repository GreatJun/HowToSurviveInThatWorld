
/// <summary>
/// # 리터럴즈 (상수형 데이터 관리)
///  - 사용 시 다음을 준수 해주세요.
///  - 자신이 사용할 부분에 대해 리전(#region)을 꼭 지정해서 사용 하십시오.
///  - 만약 해당 리전이 없다면 생성해서 사용 하십시오.
///
/// ex)
///   #region Enemy Names
///     public const string ENEMY_CREATURES_01 = "Enemy01";
///     public const string ENEMY_CREATURES_01 = "Enemy02";
///   #endregion
/// </summary>

public static class Literals
{
    #region Floating Value

    public const float ZERO_F = 0f;
    public const float HALF_F = 0.5f;
    public const float ONE_F = 1f;
    public const float TWO_F = 2f;

    #endregion

    
    
    #region DataFile Path

    public const string CSV_PATH = "Assets/@Data/CSV/";
    public const string JSON_PATH = "Assets/@Data/JSON/";

    #endregion



    #region Labels

    public const string LABEL_EMPTY = "";
    public const string LABEL_COMMON = "Common";
    
    // Scene Groups
    public const string LABEL_SCENE_SELECTOR = "SelectorScene";
    

    #endregion



    #region Base Status

    public const float HP_MIN = 0f;
    public const float HP_MAX = 999999f;

    public const float EXP_MIN = 0f;
    public const float EXP_MAX = 999999999f;

    #endregion
    
    
    
    #region Base Single Attribute
    
    // Damage
    public const float DMG_MIN = 0f;
    public const float DMG_MAX = 999999f;

    // Defense 
    public const float DEF_MIN = 0f;
    public const float DEF_MAX = 999999f;
    

    #endregion
}