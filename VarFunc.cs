public int Ammo = 20;
public float Health = 100.0;
private bool Invincible = false;

public void Shoot(){
    if(Ammo > 0){
        Ammo--;
    }
}

public void Damage(){
    if(Health > 0){
        Health--;
    }
}

public void GetHit(){
    Invincible = true;
}