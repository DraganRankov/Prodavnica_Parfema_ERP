import { Typography, Grid } from "@mui/material";
import { useFormContext } from "react-hook-form";
import AppCheckbox from "../../app/components/AppCheckbox";
import AppTextInput from "../../app/components/AppTextInput";

export default function AddressForm() {
  const { control, formState } = useFormContext();
  return (
    <>
      <Typography variant="h6" gutterBottom>
        Podaci o slanju
      </Typography>

      <Grid container spacing={3}>
        <Grid item xs={12} sm={12}>
          <AppTextInput control={control} name='fullName' label='Ime i prezime' />
        </Grid>
        <Grid item xs={12}>
          <AppTextInput control={control} name='address1' label='Adresa 1' />
        </Grid>
        <Grid item xs={12}>
          <AppTextInput control={control} name='address2' label='Adresa 2' />
        </Grid>
        <Grid item xs={12} sm={6}>
          <AppTextInput control={control} name='city' label='Grad' />
        </Grid>
        <Grid item xs={12} sm={6}>
          <AppTextInput control={control} name='state' label='Opština' />
        </Grid>
        <Grid item xs={12} sm={6}>
          <AppTextInput control={control} name='zip' label='Poštanski broj' />
        </Grid>
        <Grid item xs={12} sm={6}>
          <AppTextInput control={control} name='country' label='Zemlja' />
        </Grid>
      </Grid>

      <Grid item xs={12}>
        <AppCheckbox
          disabled={!formState.isDirty}
          name='saveAddress'
          label='Sačuvaj ovu postavku'
          control={control}
        />
      </Grid>
    </>
  );
}