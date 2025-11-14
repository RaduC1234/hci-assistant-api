using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCI.AiAssistant.API.Models.DTOs.AIAssistantController;
using Microsoft.AspNetCore.Mvc;

namespace HCI.AiAssistant.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AIAssistantController : ControllerBase
{

    [HttpPost("/message")]
    public async Task<ActionResult<AIAssistantControllerPostMessageResponseDTO>> PostMessageAsync([FromBody] AIAssistantControllerPostMessageRequestDTO request)
    {
        var responce = new AIAssistantControllerPostMessageResponseDTO
        {
            textMessage = $"You said: {request.textMessage}"
        };
        return Ok(responce);
    }
}
