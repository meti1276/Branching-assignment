using System;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
def calculate_shipping_cost(package_weight, shipping_method, package_dimensions= None):
    # Define shipping rate per pound for different methods
    rate_per_pound = {
    "standard": 1.5,
        "express": 3.0,
        "overnight": 5.0
    }

# Define a base cost for each shipping method
base_cost = {
    "standard": 10.0,
        "express": 20.0,
        "overnight": 30.0
    }

# Check if package_dimensions are provided
if package_dimensions is not None:
        # Calculate the package volume
        package_volume = package_dimensions[0] * package_dimensions[1] * package_dimensions[2]
        # Additional cost based on package volume (e.g., for oversized packages)
        if package_volume > 1000:
            additional_cost = 15.0
        else:
            additional_cost = 0.0
    else:
        additional_cost = 0.0

    # Calculate the shipping cost
    if shipping_method in rate_per_pound:
cost = base_cost[shipping_method] + (package_weight * rate_per_pound[shipping_method]) + additional_cost
        return cost
    else:
        return "Invalid shipping method"

# Example usage:
package_weight = 5.0  # in pounds
package_dimensions = (12, 8, 6)  # in inches (length, width, height)
shipping_method = "standard"
cost = calculate_shipping_cost(package_weight, shipping_method, package_dimensions)
print(f"The shipping cost is $ {cost:.2f}")

    def calculate_shipping_cost(package_weight, shipping_method, package_dimensions= None):
    # Define shipping rate per pound for different methods
    rate_per_pound = {
    "standard": 1.5,
        "express": 3.0,
        "overnight": 5.0
    }

# Define a base cost for each shipping method
base_cost = {
    "standard": 10.0,
        "express": 20.0,
        "overnight": 30.0
    }

# Calculate the package volume if dimensions are provided
if package_dimensions is not None:
        package_volume = package_dimensions[0] * package_dimensions[1] * package_dimensions[2]
    else:
        package_volume = 0

    # Calculate the shipping cost based on weight and shipping method
    shipping_cost = rate_per_pound.get(shipping_method, 1.0) * package_weight

    # Check for oversized packages and add a flat fee if necessary
    if package_volume > 1000:
        shipping_cost += 10.0

    # Add the base cost to the shipping cost
    shipping_cost += base_cost.get(shipping_method, 0.0)

    return shipping_cost

# Example usage:
package_weight = 5.0  # in pounds
package_dimensions = (12, 8, 6)  # in inches (length, width, height)
shipping_method = "standard"
cost = calculate_shipping_cost(package_weight, shipping_method, package_dimensions)
print(f"The shipping cost is $ {cost:.2f}")

