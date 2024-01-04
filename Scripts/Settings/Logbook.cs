@using Omnidroid.Resources.Scripts.Settings;

<div class="nav-menu" hidden="@Interface.MainMenu">
    <div class="divider">Journal</div>
    <nav class="">
        <div class="nav-item">
            <NavLink class="nav-link" href="" Match="NavLinkMatch.All">
                <span class="bi bi-house-door-fill-nav-menu" aria-hidden="true"></span> Summary
            </NavLink>
        </div>
        <div class="nav-item">
            <NavLink class="nav-link" href="administration">
                <span class="bi bi-list-nested-nav-menu" aria-hidden="true"></span> Administration
            </NavLink>
        </div>
        <div class="nav-item">
            <NavLink class="nav-link" href="logbook">
                <i class="material-icons">view_module</i>
                <p>Logbook</p>
            </NavLink>
        </div>
        </nav>
    <div class="divider">Administrator</div>
        <nav>
        <div class="nav-item">
            <NavLink class="nav-link" href="catalogus">
                <span class="bi bi-plus-square-fill-nav-menu" aria-hidden="true"></span> Catalogus
            </NavLink>
        </div>
        <div class="nav-item">
            <NavLink class="nav-link" href="calculus">
                <span class="bi bi-plus-square-fill-nav-menu" aria-hidden="true"></span> Calculus
            </NavLink>
        </div>
        <div class="nav-item">
            <NavLink class="nav-link" href="chat">
                <span class="bi bi-plus-square-fill-nav-menu" aria-hidden="true"></span> Chat
            </NavLink>
        </div>
    </nav>
</div>

