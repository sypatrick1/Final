@page
@model PokemonModel  
<div class="row">
    <div class="col-4 border border-warning">
        <form method="post">
            <div class="form-group">
                <label class="control-label" asp-for="Individual"></label>
                <input class="form-control" asp-for="Individual" />
                <span asp-validation-for="Individual" class="text-danger"></span>
            </div>
            <div class="form-group">
               <label asp-for="Pokemon Series"></label>
                <select asp-for="Pokemon Series" asp-items="Model.PokemonDropDown" class="form-control">
                    <option value="">-- Select PokemonSeries --</option>
                </select>
            </div>
            <div class="form-group">
                <input type="submit" value="Submit" class="btn btn-primary" />
            </div>
        </form>