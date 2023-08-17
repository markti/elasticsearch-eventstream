
resource "azurerm_kusto_cluster" "main" {
  name                = "adx${var.application_name}${random_string.name.result}"
  location            = azurerm_resource_group.main.location
  resource_group_name = azurerm_resource_group.main.name

  sku {
    name     = var.adx_cluster_instance_size
    capacity = var.adx_cluster_instance_count
  }
}