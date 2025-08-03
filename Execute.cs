[HttpPost("api/execute")]
public IActionResult Execute([FromBody] ExecuteRequest req)
{
    var parameters = new[]
    {
        new SqlParameter("@pSp_code", req.ApiCode),
        new SqlParameter("@pParameters", req.JsonParameters),
        new SqlParameter("@pStatus", SqlDbType.Int) { Direction = ParameterDirection.Output },
        new SqlParameter("@pStatus_details", SqlDbType.NVarChar, -1) { Direction = ParameterDirection.Output }
    };

    _dbContext.Database.ExecuteSqlRaw("EXEC spSysExecuteJsonSP @pSp_code, @pParameters, @pStatus OUTPUT, @pStatus_details OUTPUT", parameters);

    return Ok(new
    {
        Status = (int)parameters[2].Value,
        Details = parameters[3].Value?.ToString()
    });
}
