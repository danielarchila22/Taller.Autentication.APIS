namespace DevWorkshop.TaskAPI.Application.DTOs.Auth;

/// <summary>
/// DTO para la respuesta de autenticación
/// </summary>
public class AuthResponseDto
{
    /// <summary>
    /// Token JWT generado para el usuario
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Fecha y hora de expiración del token
    /// </summary>
    public DateTime ExpiresAt { get; set; }

    /// <summary>
    /// Información del usuario autenticado
    /// </summary>
    public UserInfo User { get; set; } = new();
}