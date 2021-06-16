 
import appconfig from '../../../../../../../app_config';
 
export class ApiUrl{
    public static get AddPet(){
        return appconfig.endpoint_url+"adoption/addpet"
    }
}